using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMFramework.Localization
{
    public class ReEncodeQuestionTranslatable : Translatable
    {
        public ReEncodeQuestionTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Re-encode video?*";
    }
    public class CompleteLabelTranslatable : Translatable
    {
        public CompleteLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Complete";
    }
    public class ReverseLabelTranslatable : Translatable
    {
        public ReverseLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reverse";
    }
    public class VideoTooBigMessageTranslatable : Translatable
    {
        public VideoTooBigMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video file exceeds 1 minute. If you continue it is possible your computer will run out of memory during the process and freeze. Do you still want to continue?";
    }
    public class SeekForwardLabelTranslatable : Translatable
    {
        public SeekForwardLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Forward (5 sec.)";
    }
    public class JumpToTimeLabelTranslatable : Translatable
    {
        public JumpToTimeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Jump to time";
    }
    public class ConverterTranslatable : Translatable
    {
        public ConverterTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Converter";
    }
    public class AddChapterTranslatable : Translatable
    {
        public AddChapterTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add Chapters";
    }
    public class VideoSuccessfullyConvertedTranslatable : Translatable
    {
        public VideoSuccessfullyConvertedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video successfully converted!";
    }
    public class VideoSuccessfullyReversedTranslatable : Translatable
    {
        public VideoSuccessfullyReversedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video successfully reversed!";
    }
    public class WarningLabelTranslatable : Translatable
    {
        public WarningLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Warning";
    }
    public class MergerTranslatable : Translatable
    {
        public MergerTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Merger";
    }
    public class ConfirmationLabelTranslatable : Translatable
    {
        public ConfirmationLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Confirmation";
    }

    public class CombiningSectionsLabelTranslatable : Translatable
    {
        public CombiningSectionsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Combining sections...";
    }
    public class RamUsageLabelTranslatable : Translatable
    {
        public RamUsageLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "RAM usage exceeds {0}%.";
    }
    public class CombiningSectionsIntoOneLabelTranslatable : Translatable
    {
        public CombiningSectionsIntoOneLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Combining sections into one video...";
    }
    public class OutputFolderLabelTranslatable : Translatable
    {
        public OutputFolderLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Select output folder";
    }
    public class CancelLabelTranslatable : Translatable
    {
        public CancelLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Cancel";
    }
    public class OutputFormatQuestionTranslatable : Translatable
    {
        public OutputFormatQuestionTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Output to a different format?";
    }
    public class ChangingLabelTranslatable : Translatable
    {
        public ChangingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Changing video speed...";
    }
    public class TrimmingSectionsLabelTranslatable : Translatable
    {
        public TrimmingSectionsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Trimming video into sections...";
    }
    public class ReducingSizeLabelTranslatable : Translatable
    {
        public ReducingSizeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reducing video size...";
    }
    public class ConvertFormatLabelTranslatable : Translatable
    {
        public ConvertFormatLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Convert video format";
    }
    public class ReverseVideoMessageTranslatable : Translatable
    {
        public ReverseVideoMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reversing a video uses a lot of computer resources and can be time consuming. If you are going to reverse a video, make sure of the following:\n  1) It is best to not have other big programs running.\nAre you sure you want to continue?";
    }
    public class SelectFileLabelTranslatable : Translatable
    {
        public SelectFileLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Click to select a file...";
    }
    public class CombineSectionsQuestionTranslatable : Translatable
    {
        public CombineSectionsQuestionTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Combine sections into one video?";
    }
    public class DeleteSectionConfirmTranslatable : Translatable
    {
        public DeleteSectionConfirmTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Do you want to delete this section?";
    }
    public class ImportLabelTranslatable : Translatable
    {
        public ImportLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Import Chapter File";
    }
    public class VideoCounterLabelTranslatable : Translatable
    {
        public VideoCounterLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video {0} of {1}";
    }

    public class PlaylistCounterLabelTranslatable : Translatable
    {
        public PlaylistCounterLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Playlist {0} of {1}";
    }
    public class SizeReducerTranslatable : Translatable
    {
        public SizeReducerTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Size Reducer";
    }
    public class ConfirmTranslatable : Translatable
    {
        public ConfirmTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Confirm";
    }
    public class SettingMetadataMessageTranslatable : Translatable
    {
        public SettingMetadataMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Setting metadata...";
    }
    public class ReversingSectionsLabelTranslatable : Translatable
    {
        public ReversingSectionsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reversing sections...";
    }
    public class OutputFormatLabelTranslatable : Translatable
    {
        public OutputFormatLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Output format";
    }
    public class MoveUpLabelTranslatable : Translatable
    {
        public MoveUpLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Move selected up";
    }

    public class MoveDownLabelTranslatable : Translatable
    {
        public MoveDownLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Move selected down";
    }

    public class SpeedChangerTranslatable : Translatable
    {
        public SpeedChangerTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Change Speed";
    }
    public class InsufficientTitlesTranslatable : Translatable
    {
        public InsufficientTitlesTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "There is not a title for every section. Click on the red sections to double check the title names.";
    }
    public class SplitterTranslatable : Translatable
    {
        public SplitterTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Splitter";
    }
    public class SeekBackLabelTranslatable : Translatable
    {
        public SeekBackLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Back (5 sec.)";
    }
    public class RemoveLabelTranslatable : Translatable
    {
        public RemoveLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Remove";
    }
    public class RemoveSelectedLabelTranslatable : Translatable
    {
        public RemoveSelectedLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Remove selected";
    }
    public class OperationCancelledTranslatable : Translatable
    {
        public OperationCancelledTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Operation cancelled.";
    }
    public class InformationLabelTranslatable : Translatable
    {
        public InformationLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Information";
    }
    public class ConvertLabelTranslatable : Translatable
    {
        public ConvertLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Convert";
    }
    public class VideoSpeedLabelTranslatable : Translatable
    {
        public VideoSpeedLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video speed";
    }
    public class SizeSuccessfullyReducedTranslatable : Translatable
    {
        public SizeSuccessfullyReducedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Size successfully reduced!";
    }
    public class ErrorLabelTranslatable : Translatable
    {
        public ErrorLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Error";
    }
    public class VideoSuccessfullySplitTranslatable : Translatable
    {
        public VideoSuccessfullySplitTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video successfully split!";
    }
    public class ReduceVideoSizeLabelTranslatable : Translatable
    {
        public ReduceVideoSizeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reduce video file size";
    }
    public class ChaptersSuccessfullyAddedTranslatable : Translatable
    {
        public ChaptersSuccessfullyAddedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Chapters markers successfully added!";
    }
    public class ReverserTranslatable : Translatable
    {
        public ReverserTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reverser";
    }
    public class SplitLabelTranslatable : Translatable
    {
        public SplitLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Split";
    }
    public class EndTimeLabelTranslatable : Translatable
    {
        public EndTimeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "End time";
    }
    public class StopLabelTranslatable : Translatable
    {
        public StopLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Stop";
    }
    public class DownloaderTranslatable : Translatable
    {
        public DownloaderTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Youtube Downloader";
    }
    public class EndTimeAfterStartTimeTranslatable : Translatable
    {
        public EndTimeAfterStartTimeTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "End time must be after the start time. Please select the start time again.";
    }
    public class FormatLabelTranslatable : Translatable
    {
        public FormatLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Format";
    }
    public class PlayLabelTranslatable : Translatable
    {
        public PlayLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Play";
    }
    public class VideoEditorTranslatable : Translatable
    {
        public VideoEditorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video Editor";
    }
    public class AddChaptersMessageTranslatable : Translatable
    {
        public AddChaptersMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add chapter markers to video?";
    }

    public class AddChapterTitleTranslatable : Translatable
    {
        public AddChapterTitleTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add chapter title";
    }

    public class PauseLabelTranslatable : Translatable
    {
        public PauseLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Pause";
    }
    public class ChapterFileFormatMessageTranslatable : Translatable
    {
        public ChapterFileFormatMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Chapter file should be in the following format:";
    }
    public class VideoSpeedSuccessfullyChangedTranslatable : Translatable
    {
        public VideoSpeedSuccessfullyChangedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video speed successfully changed!";
    }
    public class ReduceSizeTranslatable : Translatable
    {
        public ReduceSizeTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reduce Size";
    }
    public class MergeLabelTranslatable : Translatable
    {
        public MergeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Merge";
    }
    public class GettingMetadataMessageTranslatable : Translatable
    {
        public GettingMetadataMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Getting metadata...";
    }
    public class MergingLabelTranslatable : Translatable
    {
        public MergingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Merging videos...";
    }
    public class ChapterAdderTryAgainTranslatable : Translatable
    {
        public ChapterAdderTryAgainTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Try again by importing the chapter marker file located at {0}.";
    }
    public class FlipLabelTranslatable : Translatable
    {
        public FlipLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Flip";
    }
    public class ConvertingLabelTranslatable : Translatable
    {
        public ConvertingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Converting video...";
    }
    public class SplittingLabelTranslatable : Translatable
    {
        public SplittingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Splitting video...";
    }
    public class ReEncodeCommentTranslatable : Translatable
    {
        public ReEncodeCommentTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "*Re-encoding is more time-consuming, but the start and end times will be more accurate and it will prevent any black frames at the beginning and end of the clips.";
    }
    public class ErrorOccurredTranslatable : Translatable
    {
        public ErrorOccurredTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "An error has occurred. Please close and reopen the program. Check your task manager and make sure any remaining \"ffmpeg.exe\" tasks are ended.";
    }
    public class RotateLabelTranslatable : Translatable
    {
        public RotateLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Rotate";
    }
    public class VideoSuccessfullyMergedTranslatable : Translatable
    {
        public VideoSuccessfullyMergedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Videos successfully merged!";
    }
    public class StartTimeLabelTranslatable : Translatable
    {
        public StartTimeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Start time";
    }

    public class DownloadLabelTranslatable : Translatable
    {
        public DownloadLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Download";
    }

    public class DownloadingLabelTranslatable : Translatable
    {
        public DownloadingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Downloading...";
    }

    public class AddUrlLabelTranslatable : Translatable
    {
        public AddUrlLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add URL";
    }

    public class VideoSuccessfullyDownloadedTranslatable : Translatable
    {
        public VideoSuccessfullyDownloadedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video successfully downloaded!";
    }

    public class IsPlaylistTranslatable : Translatable
    {
        public IsPlaylistTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Is this a playlist?";
    }

    public class EnterTitleTranslatable : Translatable
    {
        public EnterTitleTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Enter title...";
    }

    public class EnterUrlTranslatable : Translatable
    {
        public EnterUrlTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Enter URL...";
    }

    public class TextCannotBeEmptyTranslatable : Translatable
    {
        public TextCannotBeEmptyTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Text cannot be empty.";
    }

    public class ChapterAdderTranslatable : Translatable
    {
        public ChapterAdderTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Chapter Adder";
    }

    public class UnhandledExceptionTranslatable : Translatable
    {
        public UnhandledExceptionTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Unhandled Exception";
    }

    public class SelectOutputFolderTranslatable : Translatable
    {
        public SelectOutputFolderTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Please select an output folder.";
    }

    public class DragFileTranslatable : Translatable
    {
        public DragFileTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Drag video files here...";
    }

    public class ChapterMarkerCompatibleFormatsTranslatable : Translatable
    {
        public ChapterMarkerCompatibleFormatsTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Chapter markers are only compatible with the following formats: {0}";
    }

    public class FileAlreadyExistsTranslatable : Translatable
    {
        public FileAlreadyExistsTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "The file {0} already exists. Overwrite? (Select \"No\" to output to a different file name.)";
    }

    public class OnlyVideoFilesTranslatable : Translatable
    {
        public OnlyVideoFilesTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Only video files can be added";
    }

    public class PlaylistEmptyTranslatable : Translatable
    {
        public PlaylistEmptyTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "This playlist is empty. No videos were downloaded";
    }

    public class DownloadAudioOnlyTranslatable : Translatable
    {
        public DownloadAudioOnlyTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Download audio only?";
    }

    public class AddTranslatable : Translatable
    {
        public AddTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add";
    }

    public class UrlAddedTranslatable : Translatable
    {
        public UrlAddedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "URL added!";
    }

    public class AddUrlsForVideoPlaylistTranslatable : Translatable
    {
        public AddUrlsForVideoPlaylistTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add URLs for videos or playlists";
    }

    public class DoneTranslatable : Translatable
    {
        public DoneTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Done";
    }

    public class CropperTranslatable : Translatable
    {
        public CropperTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video Cropper";
    }

    public class ImageCropperTranslatable : Translatable
    {
        public ImageCropperTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Image Cropper";
    }

    public class CropTranslatable : Translatable
    {
        public CropTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Crop";
    }

    public class VideoSuccessfullyCroppedTranslatable : Translatable
    {
        public VideoSuccessfullyCroppedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video successfully cropped!";
    }

    public class ImageSuccessfullyCroppedTranslatable : Translatable
    {
        public ImageSuccessfullyCroppedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Image successfully cropped!";
    }

    public class CroppingLabelTranslatable : Translatable
    {
        public CroppingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Cropping video...";
    }

    public class OpenCropWindowTranslatable : Translatable
    {
        public OpenCropWindowTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Open crop window";
    }

    public class EmbedSubsLabelTranslatable : Translatable
    {
        public EmbedSubsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Embed subtitles for avi files?";
    }

    public class DeleteChapterFileLabelTranslatable : Translatable
    {
        public DeleteChapterFileLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Delete chapter file after process has completed?";
    }


    #region Bank Client

    public class WelcomeTranslatable : Translatable
    {
        public WelcomeTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Welcome to J Bank";
    }

    public class DepositTranslatable : Translatable
    {
        public DepositTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "deposit";
    }

    public class DepositCommandTranslatable : Translatable
    {
        public DepositCommandTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Deposit";
    }

    public class WithdrawTranslatable : Translatable
    {
        public WithdrawTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "withdraw";
    }

    public class WithdrawCommandTranslatable : Translatable
    {
        public WithdrawCommandTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Withdraw";
    }

    public class TransferTranslatable : Translatable
    {
        public TransferTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "transfer";
    }

    public class TransferCommandTranslatable : Translatable
    {
        public TransferCommandTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Transfer";
    }

    public class OperationQuestionTranslatable : Translatable
    {
        public OperationQuestionTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Enter the amount to {0}:";
    }

    public class FailedToGetAccountDetailsErrorTranslatable : Translatable
    {
        public FailedToGetAccountDetailsErrorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Failed to get account details: {0}";
    }

    public class ErrorTranslatable : Translatable
    {
        public ErrorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Error";
    }

    public class InformationTranslatable : Translatable
    {
        public InformationTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Information";
    }

    public class AmountGreaterThanZeroTranslatable : Translatable
    {
        public AmountGreaterThanZeroTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Please enter an amount greater than 0";
    }

    public class OperationFailedErrorTranslatable : Translatable
    {
        public OperationFailedErrorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Operation failed: {0}";
    }

    public class EnterUserForTransferTranslatable : Translatable
    {
        public EnterUserForTransferTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Please enter a user to transfer funds to";
    }

    public class TransferFailedErrorTranslatable : Translatable
    {
        public TransferFailedErrorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Transfer failed : {0}";
    }

    public class UsernameDoesNotExistTranslatable : Translatable
    {
        public UsernameDoesNotExistTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "This username does not exist";
    }

    public class LoginSuccessfulTranslatable : Translatable
    {
        public LoginSuccessfulTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Log in successful";
    }

    public class LoginFailedErrorTranslatable : Translatable
    {
        public LoginFailedErrorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Log in failed: {0}";
    }

    public class LogoutSuccessfulTranslatable : Translatable
    {
        public LogoutSuccessfulTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Log out successful";
    }

    public class LogoutFailedErrorTranslatable : Translatable
    {
        public LogoutFailedErrorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Log out failed: {0}";
    }

    public class SignUpSuccessfulTranslatable : Translatable
    {
        public SignUpSuccessfulTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Sign up successful";
    }

    public class SignUpFailedErrorTranslatable : Translatable
    {
        public SignUpFailedErrorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Sign up failed: {0}";
    }

    public class CheckingLabelTranslatable : Translatable
    {
        public CheckingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Checking";
    }

    public class SavingLabelTranslatable : Translatable
    {
        public SavingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Saving";
    }

    public class UsernameAlreadyExistsTranslatable : Translatable
    {
        public UsernameAlreadyExistsTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "This username already exists";
    }

    public class FailedToGetTransactionsErrorTranslatable : Translatable
    {
        public FailedToGetTransactionsErrorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Failed to get transactions: {0}";
    }

    public class LoginLabelTranslatable : Translatable
    {
        public LoginLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Log in";
    }

    public class LogoutLabelTranslatable : Translatable
    {
        public LogoutLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Log out";
    }

    public class SignUpLabelTranslatable : Translatable
    {
        public SignUpLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Sign up";
    }

    public class UsernameLabelTranslatable : Translatable
    {
        public UsernameLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Username";
    }

    public class PasswordLabelTranslatable : Translatable
    {
        public PasswordLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Password";
    }

    public class FirstNameLabelTranslatable : Translatable
    {
        public FirstNameLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "First name";
    }

    public class LastNameLabelTranslatable : Translatable
    {
        public LastNameLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Last name";
    }

    public class AccountTypeLabelTranslatable : Translatable
    {
        public AccountTypeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Account type";
    }

    public class BalanceLabelTranslatable : Translatable
    {
        public BalanceLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Balance";
    }

    public class RecentTransactionsLabelTranslatable : Translatable
    {
        public RecentTransactionsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Recent transactions";
    }

    public class HomeLabelTranslatable : Translatable
    {
        public HomeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Home";
    }

    public class AccountLabelTranslatable : Translatable
    {
        public AccountLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Account";
    }

    public class UserDetailsLabelTranslatable : Translatable
    {
        public UserDetailsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "User details";
    }

    public class TransactionsLabelTranslatable : Translatable
    {
        public TransactionsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Transactions";
    }

    public class CancelTranslatable : Translatable
    {
        public CancelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Cancel";
    }

    public class UsernameEmptyTranslatable : Translatable
    {
        public UsernameEmptyTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Please enter a username";
    }

    public class PasswordEmptyTranslatable : Translatable
    {
        public PasswordEmptyTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Please enter a password";
    }

    public class FirstNameEmptyTranslatable : Translatable
    {
        public FirstNameEmptyTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Please enter a first name";
    }

    public class LastNameEmptyTranslatable : Translatable
    {
        public LastNameEmptyTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Please enter a last name";
    }

    public class NameOfRecipientTranslatable : Translatable
    {
        public NameOfRecipientTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Username of recipient";
    }

    public class SessionInvalidLoggingOutTranslatable : Translatable
    {
        public SessionInvalidLoggingOutTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "The current session is invalid. You will be logged out.";
    }

    public class SaveTranslatable : Translatable
    {
        public SaveTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Save";
    }

    public class BankErrorOccurredTranslatable : Translatable
    {
        public BankErrorOccurredTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "An error occurred: {0}";
    }

    #endregion
}
